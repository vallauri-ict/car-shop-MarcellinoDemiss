using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace carShopDllProject
{
    public class dbUtils
    {
        public static string conStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\CarShop.accdb";

        public static void creaTabella(string nomeTabella)
        {
            if (conStr != null)
            {
                OleDbConnection con = new OleDbConnection(conStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;

                    try
                    {
                        string command = $@"CREATE TABLE {nomeTabella}( id INT identity(1,1) NOT NULL PRIMARY KEY, marca VARCHAR(255) NOT NULL, modello VARCHAR(255) NOT NULL,
                                colore VARCHAR(255), cilindrata INT, potenzaKw INT,
                                immatricolazione DATE, usato VARCHAR(255), kmZero VARCHAR(255),
                                kmPercorsi INT, prezzo INT,";
                        if (nomeTabella == "Auto") command += " numAirbag INT)";
                        else command += " marcaSella VARCHAR(255))";
                        cmd.CommandText = command;
                        cmd.ExecuteNonQuery();
                    }
                    catch (OleDbException ex)
                    {
                        Console.WriteLine($"\n\n{ex.Message}");
                        System.Threading.Thread.Sleep(3000);
                        return;
                    }
                }
            }
        }

        public static void aggiungiItem(string nomeTabella, string marca, string modello, string colore, int cilindrata,
            int potenzaKw, DateTime immatricolazione, string usata, string isKm0, int kmPercorsi, int prezzo, int numAirbag, string marcaSella)
        {
            if (conStr != null)
            {
                OleDbConnection con = new OleDbConnection(conStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    string command = string.Empty;
                    if (nomeTabella == "Auto")
                        command = $"INSERT INTO {nomeTabella}(marca, modello, colore, cilindrata, potenzaKw, immatricolazione, usato, kmZero, kmPercorsi, prezzo, numAirbag) VALUES(@marca, @modello, @colore, @cilindrata, @potenzaKw, @immatricolazione, @usata, @isKm0, @kmPercorsi, @prezzo, @numAirbag)";
                    else
                        command = $"INSERT INTO {nomeTabella}(marca, modello, colore, cilindrata, potenzaKw, immatricolazione, usato, kmZero, kmPercorsi, prezzo, marcaSella) VALUES(@marca, @modello, @colore, @cilindrata, @potenzaKw, @immatricolazione, @usata, @isKm0, @kmPercorsi, @prezzo, @marcaSella)";
                    cmd.CommandText = command;

                    string used = usata;
                    string km0 = isKm0;
                    cmd.Parameters.Add(new OleDbParameter("@marca", OleDbType.VarChar, 255)).Value = marca;
                    cmd.Parameters.Add(new OleDbParameter("@modello", OleDbType.VarChar, 255)).Value = modello;
                    cmd.Parameters.Add(new OleDbParameter("@colore", OleDbType.VarChar, 255)).Value = colore;
                    cmd.Parameters.Add("@cilindrata", OleDbType.Integer).Value = cilindrata;
                    cmd.Parameters.Add("@potenzaKw", OleDbType.Integer).Value = potenzaKw;
                    cmd.Parameters.Add(new OleDbParameter("@immatricolazione", OleDbType.Date)).Value = immatricolazione.ToShortDateString();
                    cmd.Parameters.Add(new OleDbParameter("@usato", OleDbType.VarChar, 255)).Value = used;
                    cmd.Parameters.Add(new OleDbParameter("@isKm0", OleDbType.VarChar, 255)).Value = km0;
                    cmd.Parameters.Add("@kmPercorsi", OleDbType.Integer).Value = kmPercorsi;
                    cmd.Parameters.Add("@prezzo", OleDbType.Double).Value = prezzo;
                    if (nomeTabella == "Auto")
                        cmd.Parameters.Add("@numAirbag", OleDbType.Integer).Value = numAirbag;
                    else
                        cmd.Parameters.Add(new OleDbParameter("@marcaSella", OleDbType.VarChar, 255)).Value = marcaSella;
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        //non funziona
        public static void listaTabella(string nomeTabella)
        {
            if (conStr != null)
            {
                OleDbConnection con = new OleDbConnection(conStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand command = new OleDbCommand($"SELECT * FROM {nomeTabella}", con);

                    OleDbDataReader rdr = command.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        Console.WriteLine("\n");
                        while (rdr.Read())
                        {
                            string immatricolaz = rdr.GetDateTime(6).ToShortDateString();

                            string output = $"{rdr.GetString(0)} - {rdr.GetString(1)} - {rdr.GetString(2)} - " +
                                            $"{rdr.GetString(3)} - {rdr.GetInt32(4)} - {rdr.GetInt32(5)} - " +
                                            $"{immatricolaz} - {rdr.GetString(7)} - {rdr.GetString(8)} - {rdr.GetInt32(9)} - " +
                                            $"{rdr.GetInt32(10)} - {rdr.GetInt32(11)} - {rdr.GetString(12)}";
                            Console.WriteLine(output);
                        }
                    }
                    else Console.WriteLine("\n\nNo rows found.");
                    rdr.Close();
                }
            }
        }

        public static void eliminaItem(string tableName, int id)
        {
            if (conStr != null)
            {
                OleDbConnection con = new OleDbConnection(conStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand($"DELETE FROM {tableName} WHERE id={id}", con);

                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void eliminaTabella(string tableName)
        {
            if (conStr != null)
            {
                OleDbConnection con = new OleDbConnection(conStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    string command = $"DROP TABLE {tableName}";
                    cmd.CommandText = command;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static int trovaId(string table)
        {
            int maxId = dbUtils.contatore(table);
            int id;
            do
            {
                Console.WriteLine($"Inserisci un numero da 1 a {maxId}: ");
                id = Convert.ToInt32(Console.ReadLine());
            } while (id < 1 || id > maxId);
            return id;
        }

        public static int contatore(string tableName)
        {
            if (conStr != null)
            {
                OleDbConnection con = new OleDbConnection(conStr);

                using (con)
                {
                    con.Open();

                    OleDbCommand command = new OleDbCommand($"SELECT MAX(id) FROM {tableName}", con);

                    OleDbDataReader rdr = command.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            return rdr.GetInt32(0);
                        }
                    }
                    else Console.WriteLine("\n\nNo rows found.");
                    rdr.Close();
                }
            }
            return -1;
        }
    }
}
