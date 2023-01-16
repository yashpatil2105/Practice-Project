namespace DAL;
using BOL;

public class VehicleManager:IVehicleManager
{
    public List<Vehicle> GetAll(){
       using (var context = new CollectionContext()){
        var vehicles=from veh in context.Vehicles select veh;
        return vehicles.ToList<Vehicle>(); 
       }
    }
    public Vehicle GetById(int vid){
       using (var context = new CollectionContext()){
        var veh = context.Vehicles.Find(vid);
        return veh;
       }
    }
    public void Insert(Vehicle veh){
       using (var context = new CollectionContext()){
           context.Vehicles.Add(veh);
           context.SaveChanges();
       }
    }
    public void Update(Vehicle veh){
        using (var context = new CollectionContext())
        {
            var theVeh = context.Vehicles.Find(veh.Vid);
            theVeh.Vname =veh.Vname;
            theVeh.Price=veh.Price;
            theVeh.Descript=veh.Descript;
            context.SaveChanges();
        }

    }
    public void Delete(int vid){
        using(var context = new CollectionContext())
        {
            context.Vehicles.Remove(context.Vehicles.Find(vid));
            context.SaveChanges();
        }

    }

}