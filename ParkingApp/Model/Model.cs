using Newtonsoft.Json;
using System;
using System.Collections;
using System.Diagnostics.Metrics;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Xml.Linq;
using static System.Windows.Forms.Design.AxImporter;

namespace ParkingApp
{
    // 
    // JSON classes for deserialization
    // 
    public class Gateway
    {
        public string gate { get; set; }
        public string direction { get; set; }
    }
    public  class JSONCountObject
    {
        public int count { get; set; }
        public string category { get; set; }
        public string name { get; set; }
        public string zone { get; set; }
        public double timestamp { get; set; }
        public Gateway gateway { get; set; }
        public string user { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string transaction_id { get; set; }

    }

    public class Extra
    {
        public string card_name { get; set; }
        public string date_day { get; set; }
        public string additional { get; set; }
        public string card_sequence_number { get; set; }
        public string receipt { get; set; }
        public string currency_code { get; set; }
        public string card_type { get; set; }
        public string amount { get; set; }
        public string vu { get; set; }
        public string time { get; set; }
        public string tid { get; set; }
        public string aid { get; set; }
        public string trace_number { get; set; }
        public string type { get; set; }
        public string card_number { get; set; }
        public string result_code { get; set; }
        public string turnover { get; set; }
    }

    public class OmPayload
    {
        public string occupant_id { get; set; }
        public string transaction_id { get; set; }
        public string zone { get; set; }
        public string id { get; set; }
    }

    public class PaymentPayload
    {
        public string payment_id { get; set; }
        public int amount { get; set; }
        public string payment_type { get; set; }
        public Extra extra { get; set; }
    }

    public class JSONPaymentObject
    {
        public OmPayload om_payload { get; set; }
        public double timestamp { get; set; }
        public string receipt { get; set; }
        public string type { get; set; }
        public PaymentPayload payment_payload { get; set; }
        public string name { get; set; }
    }
    // 
    //
    // 

    public class Model
    {

        public Model() {


        }

        private string? _filePath;
        private StreamReader? _streamReader;

        List<string> _jsonObjects = new List<string>();
        List<JsonObject> _jsonObjectsClasses = new List<JsonObject>();
        List<Dictionary<string, string>> returnDictionary = new List<Dictionary<string, string>>();


        ~Model()
        {

            if (_streamReader != null)
            {
                _streamReader.Dispose();
            }
        }


        // Parses and sorts the model loaded text file.
        // parameter: none
        // returns: a sorted dictionary or null List<JsonObjectClass>
        internal List<Dictionary<string, string>> Search(string licenceText, string lastFourDigits, DateTime paymentDate)
        {
            returnDictionary.Clear();
            foreach (string stra in _jsonObjects)
            {
    
                List<object> root = JsonConvert.DeserializeObject<List<object>>(stra);

                if (root != null)
                {


                    string a = (string)root[0];
                    if (a.Equals("count"))
                    {
                        continue;
                        JSONCountObject b = JsonConvert.DeserializeObject<JSONCountObject>(root[1].ToString());
                        return returnDictionary;

                    }
                    if (a.Equals("payment"))
                    {
                        JSONPaymentObject b = JsonConvert.DeserializeObject<JSONPaymentObject>(root[1].ToString());
                        if (b == null) continue;
                        if (b.payment_payload == null) continue;

                        string card_nr = ExtractCardNr(b.payment_payload.extra.card_number);
                        DateTime dateTime = ExtractTime(b.timestamp);


                        if (licenceText.Equals(b.om_payload.id) && lastFourDigits.Equals(card_nr))
                        {
                            int day = dateTime.Day;
                            int month = dateTime.Month;
                            int year = dateTime.Year;
                            int paymentDay = paymentDate.Day;
                            int paymentMonth = paymentDate.Month;
                            int paymentYear = paymentDate.Year; 

                            if (day == paymentDay && month == paymentMonth && year == paymentYear) {

                                Dictionary<string, string> tempDictionary = new Dictionary<string, string>();
                                tempDictionary.Add("Message", b.receipt);
                                tempDictionary.Add("LicenseplateID", b.om_payload.id);
                                tempDictionary.Add("PaymentID", b.payment_payload.payment_id);


                                tempDictionary.Add("PaymentAmount", "€" + b.payment_payload.extra.amount.TrimStart('0')+".-");
                                returnDictionary.Add(tempDictionary);
                            }
                        
                        }
                    }
                }
            }
            //return b.receipt;
            return returnDictionary;
        }

        private DateTime ExtractTime(double timestamp)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            dateTime = dateTime.AddSeconds(timestamp).ToLocalTime();
            return dateTime;

        }

        private string ExtractCardNr(string card_number)
        {
            // remove last char
            string temp = card_number.Remove(card_number.Length - 1, 1);
            temp = temp.Replace(" ", "");

            // read last four string characters
            temp = temp.Substring(temp.Length - 4);
            return temp;


            
        }

        // Clear model dictionary used in parsing
        internal void ClearContents()
        {

            _jsonObjectsClasses.Clear();
            _jsonObjects.Clear();
            returnDictionary.Clear();
            _streamReader?.Dispose();

        }
        internal void ReloadStream()
        {
            if (_filePath == null)
            {
                throw new Exception("File path is null. You must load a file first.");

            }
            if (_streamReader != null)
            {
                _streamReader.Dispose();
                _streamReader = new StreamReader(this._filePath);
            }

        }
            // Loads file
            // parameter: file path
            // returns: stream reader
            internal void LoadFile(string file_path)
        {
            ClearContents();

            this._filePath = file_path;



            try
            {
                if (_streamReader != null)
                {
                    _streamReader.Dispose();
                    _streamReader = new StreamReader(file_path);
                }
                else
                {

                    _streamReader = new StreamReader(file_path);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
            }

            ParseJson();



        }
        internal void ParseJson()
        {
            try
            {
                if (_streamReader != null)
                {
                    string? readLine = "";


                    if ((readLine = _streamReader.ReadLine()) == null)
                    {
                        throw new InvalidOperationException("Cannot read json file");
                    }
                    else
                    {
                        ReloadStream();
                    }
                    while ((readLine = _streamReader.ReadLine()) != null)
                    {

                        if (readLine.StartsWith("[")) _jsonObjects.Add(readLine);



                    }
                }
                else
                {
                    MessageBox.Show($"Json file could not be loaded.\n");
                    throw new Exception("Streamreader is null");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
            }


        }

    }
}