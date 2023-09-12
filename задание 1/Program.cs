using задание_1;

string name = Library.ReadName();
int bankProductsAmount = Library.ReadBankProductsAmount();
int totalOrders = Library.ReadTotalMoney();
int age = Library.ReadAge();

bool areOffersAvailable = Library.AreOffersAvailable(bankProductsAmount, totalOrders, age);

if(areOffersAvailable == true)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}