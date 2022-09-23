
StreamReader fileAddress = File.OpenText("C:/Users/luca8/Dropbox/Il mio PC (LAPTOP-KO0VR89I)/Downloads/addresses.csv");

fileAddress.ReadLine();

while (!fileAddress.EndOfStream)
{
    string record = fileAddress.ReadLine();

    string[] addressSplit = record.Split(',');

    try
    {
        string name = addressSplit[0].Trim();
        string surname = addressSplit[1].Trim();
        string street = addressSplit[2].Trim();
        string city = addressSplit[3].Trim();
        string province = addressSplit[4].Trim();
        string zip = addressSplit[5].Trim();

        Address address = new Address(name, surname, street, city, province, zip);
        Console.WriteLine(address.ToString());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    } 
           
}
fileAddress.Close();

