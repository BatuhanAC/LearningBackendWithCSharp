using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//CustomerManagerTest();

//ProductDtoTest();

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
    ProductManager testProductDto = new ProductManager(new EfProductDal());

    foreach (var detail in testProductDto.GetProductDetails())
    {
        Console.WriteLine("{0}/{1}/{2}", detail.CategoryName, detail.ProductName, detail.UnitsInStock);
    }
}