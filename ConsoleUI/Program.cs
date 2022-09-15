using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//CustomerManagerTest();
//ProductDtoTest();
ProductTest();


static void ProductTest()
{
    ProductManager product = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));
    var result = product.GetAll();
    if (result.Success)
    {
        foreach (var p in result.Data)
        {
            Console.WriteLine(p.ProductName);
        }
        Console.WriteLine(result.Message);
    }
    else Console.WriteLine(result.Message);
    
}


static void CustomerManagerTest()
{
    CustomerManager customerManager = new CustomerManager(new EfCustomerDal()); 

    foreach (var customer in customerManager.GetAll())
    {
        Console.WriteLine(customer.ContactName);
    }
}

static void ProductDtoTest()
{
    ProductManager testProductDto = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));
    var result = testProductDto.GetProductDetails();
    if (result.Success)
    {
        foreach (var detail in result.Data)
        {
            Console.WriteLine("{0}/{1}/{2}", detail.CategoryName, detail.ProductName, detail.UnitsInStock);
        }
    }
}