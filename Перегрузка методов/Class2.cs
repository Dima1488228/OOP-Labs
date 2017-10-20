using System;

class Owner
{
    int Id { get; set; }
    string Name { get; set; }
    string Org { get; set; }
    Owner(int id, string name, string org)
    {
        Id = id;
        Name = name;
        Org = org;
    }

}