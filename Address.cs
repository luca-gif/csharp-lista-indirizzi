public class Address
{
    string Name { get; set; }
    string Surname { get; set; }
    string Street { get; set; }
    string City { get; set; }
    string Province { get; set; }
    string Zip { get; set; }

    public Address(string name, string surname, string street, string city, string province, string zip)
    {
        Name = name;
        Surname = surname;
        Street = street;
        City = city;
        Province = province;
        Zip = zip;
    }

    public override string ToString()
    {
        string str = "";
        str += $"Name: {Name} - Surname: {Surname} - Street: {Street} - City: {City} - Province: {Province} - Zip: {Zip}";
        return str;
    }
}


