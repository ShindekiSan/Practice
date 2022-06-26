using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public class HomeLibrary
  {
    public int Number
    {
      get;
      set;
    }
    public string Author
    {
      get;
      set;
    }
    public int Year
    {
      get;
      set;
    }
    public string Category
    {
      get;
      set;
    }

    List<HomeLibrary> homeLibraryList = new List<HomeLibrary>();

    public void Add(HomeLibrary homeLibrary)
    {
      homeLibraryList.Add(homeLibrary);
    }

    public void Remove(HomeLibrary homeLibrary)
    {
      homeLibraryList.Remove(homeLibrary);

    }
    public override bool Equals(object obj)
    {
      if (obj == null) return false;

      HomeLibrary objHomeLibrary = obj as HomeLibrary;
      if (objHomeLibrary == null)
        return false;
      return true;
    }

    public override string ToString()
    {
      return Number + " " + Author + " " + Year + " " + Category;
    }

    public void ShowScreen()
    {
      foreach (var VARIABLE in homeLibraryList)
      {
        WriteLine(VARIABLE.ToString());
      }
      WriteLine("\n");
    }

    public void Search(string str, int number)
    {

      foreach (var VARIABLE in homeLibraryList)
      {
        if (number == 1 && VARIABLE.Author == str)
        {
          WriteLine(VARIABLE.ToString());
        }
        else if (number == 2 && VARIABLE.Year == Convert.ToInt32(str))
        {
          WriteLine(VARIABLE.ToString());
        }
        else if (number == 3 && VARIABLE.Category == str)
        {
          WriteLine(VARIABLE.ToString());
        }
        else if (number == 4 && VARIABLE.Number == Convert.ToInt32(str))
        {
          WriteLine(VARIABLE.ToString());
        }
      }


    }
    static void Main(string[] args)
    {
      HomeLibrary homeLibrary = new HomeLibrary();
      homeLibrary.Add(new HomeLibrary { Number = 1, Author = "Ессенин", Year = 1900, Category = "Стихи" });
      homeLibrary.Add(new HomeLibrary { Number = 2, Author = "Пушкин", Year = 1910, Category = "Рассказы" });
      homeLibrary.Add(new HomeLibrary { Number = 3, Author = "Лермонтов", Year = 1920, Category = "Басни" });
      homeLibrary.Add(new HomeLibrary { Number = 4, Author = "Достоевский", Year = 1910, Category = "Стихи" });
      homeLibrary.ShowScreen();
      homeLibrary.Remove(new HomeLibrary { Number = 3, Author = "Лермонтов", Year = 1920, Category = "Басни" });
      homeLibrary.ShowScreen();

      Console.WriteLine("По какому критерию будем производить поиск? (По автору-1, год издания-2, по категории-3, по номеру -4)");
      int number = int.Parse(ReadLine());

      switch (number)
      {
        case 1:
          Console.WriteLine("Введите  писателя");
          homeLibrary.Search(ReadLine(), number);
          break;
        case 2:
          Console.WriteLine("Введите  год издания");
          homeLibrary.Search(ReadLine(), number);
          break;
        case 3:
          Console.WriteLine("Введите  категорию");
          homeLibrary.Search(ReadLine(), number);
          break;
        case 4:
          Console.WriteLine("Введите  номер книги");
          homeLibrary.Search(ReadLine(), number);
          break;
        default:
          Console.WriteLine("Не правильный критерий");
          break;
      }

      ReadLine();
    }

  }
}