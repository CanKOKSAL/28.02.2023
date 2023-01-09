using ConsoleApp.Enums;
using ConsoleApp.Services.İmplementation;

int select;
do
{


	Console.WriteLine("1.Create Group");
	Console.WriteLine("2.Edit Group");
	Console.WriteLine("3.Create Student");
	Console.WriteLine("4.Edit Student");
	Console.WriteLine("5.Get All Student");

	int.TryParse(Console.ReadLine(), out select);


	switch (select)
	{
		case 1:
			MenuService.CreateGroup();
			break;
			
		
	}





} while (true);

