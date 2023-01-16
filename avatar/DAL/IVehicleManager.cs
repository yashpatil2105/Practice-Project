namespace DAL;
using BOL;

public interface IVehicleManager
{
    List<Vehicle> GetAll();
    Vehicle GetById(int vid);
    void Insert(Vehicle veh);
    void Update(Vehicle veh);
    void Delete(int vid);

}