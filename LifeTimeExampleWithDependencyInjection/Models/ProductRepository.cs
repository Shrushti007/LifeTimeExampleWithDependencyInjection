namespace LifeTimeExampleWithDependencyInjection.Models
{
    public class SupplierRepository : ISupplierRepository
    {
        static List<SupplierViewModel> suppliersList = new List<SupplierViewModel>()
        {
            new SupplierViewModel{SuppId = 1 , SupplierName="Raksha Enterprise",City="Pune"},
            new SupplierViewModel{SuppId = 2 , SupplierName="Shreya Services",City="Nashik"},
            new SupplierViewModel{SuppId = 3 , SupplierName="Chetana Consultants",City="Dhule"},
            new SupplierViewModel{SuppId = 4 , SupplierName="Monika Solutions", City = "Nagpur" }
        };

        public void Delete(int id)
        {
            //throw new NotImplementedException();
            SupplierViewModel model = suppliersList.Find(s=>s.SuppId== id);
            suppliersList.Remove(model);
        }

        public SupplierViewModel FindSupplier(int id)
        {
            //throw new NotImplementedException();
            SupplierViewModel model = suppliersList.Find(s => s.SuppId == id);
            return model;
        }

        public List<SupplierViewModel> GetSuppliers()
        {
            //throw new NotImplementedException();
            return suppliersList;
        }

        public void Insert(SupplierViewModel supplier)
        {
            //throw new NotImplementedException();
            suppliersList.Add(supplier);
        }

        public void Update(int id, SupplierViewModel supplier)
        {
            // throw new NotImplementedException();
            SupplierViewModel model = suppliersList.Find(s => s.SuppId == id);
           model.SupplierName = supplier.SupplierName;
            model.City = supplier.City;
        }
    }
}
