namespace BOL;

public class Vehicle{
    public Vehicle(int vid, string vname, double price, string descript)
    {
        Vid = vid;
        Vname = vname;
        Price = price;
        Descript = descript;
    }

    public int Vid{get;set;}
   public string? Vname{get;set;}
   public double Price{get;set;}
   public string? Descript{get;set;}
 
}