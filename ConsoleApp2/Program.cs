// See https://aka.ms/new-console-template for more information

using ConsoleApp2;

Console.WriteLine("Hello, World!");

var n = 0;
var v = new List<customer>();
var c = 1;
while (c > 0 && c < 5)
{
    Console.WriteLine("nhap lua chon cua ban: ");
    Console.WriteLine("1. nhap n khac hang");
    Console.WriteLine("2. tinh thanh tien");
    Console.WriteLine("3 sap xep theo thu tu giam dan");
    Console.WriteLine("4 in ra ");
    Console.WriteLine("0 thoat");
    c = int.Parse(Console.ReadLine());

    switch (c)
    {
        case 1:
            Console.WriteLine("nhap so luong khach hang");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("nhap khach hang thu" + i);
                Console.WriteLine("Loai KH(CN,CT,NN)");
                var cName = (Console.ReadLine());
                Console.WriteLine("ten hang");
                var iName = Console.ReadLine();
                Console.WriteLine("so luong");
                var q = int.Parse(Console.ReadLine());
                Console.WriteLine("don gia");
                var p = double.Parse(Console.ReadLine());
                v.Add(new customer(cName, iName, q, p));
            }

            break;

        case 2:
            {
                var temp = 0;

                foreach (customer customer in v)
                    customer.getCost();


                break;
            }
        case 3:
            {
                customer temp = null;

                for (int i = 0; i < v.Count; i++)
                {
                    for (int j = i + 1; j < v.Count; j++)
                    {
                        if (v[i].Price.CompareTo(v[j].Price) <= 0)
                        {
                            temp = v[i];
                            v[i] = v[j];
                            v[j] = temp;
                        }
                    }
                }

                break;
            }
        case 4:
            double sum = 0;
            Console.WriteLine("khach hang \t ten hang hoa \t so luon \t don gia \t thanh tien");
            foreach (customer customer in v)
            {
                sum += customer.Cost;
                Console.WriteLine(customer.CustomerName + "\t" + customer.ItemName + "\t" + customer.Qty + "\t" + customer.Price + "\t" + customer.Cost);
            }

            Console.WriteLine("tong cong thanh tien \t:" + sum);
            break;
    }
}