using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Билет5
{
  class rodent // родительский класс грызунов
  {
    public string name;
    public int height;
    public int lenght;
    public int weight;

    public rodent(int height, int lenght, int weight)
    {
      this.height = height;
      this.lenght = lenght;
      this.weight = weight;
    }

    public rodent(int height)
    {
      this.height = height;
    }
  } 

  class suslik : rodent
  {
    public suslik(int height, int lenght, int weight) : base(height, lenght, weight)
    {
      name = "Даурский суслик";
    }

  }

  class sonya : rodent
  {
    public sonya(int height) : base(height)
    {
      name = "Мышевидная соня";
    }
  }

  class slepish : rodent
  {
    public slepish(int height, int lenght, int weight) : base(height, lenght, weight)
    {
      name = "Белозубый слепыш";
    }
  }

  class cat
  {
    private string name = "Диззи";
    
    public void Hunt(List<rodent> animals)
    {
      List<rodent> eaten = new List<rodent>();
      List<rodent> caught = new List<rodent>();
      List<rodent> free = new List<rodent>();

      foreach (var x in animals)
      {
        if (x.name == "Мышевидная соня")
        {
          free.Add(x);
        }

        if (x.height > 6 && x.lenght >=5 && x.weight > 9)
        {
          caught.Add(x);
          
          if (x.name == "Белозубый слепыш")
          {
            eaten.Add(x);
            caught.Remove(x);
          }

          if (x.name == "Даурский суслик")
          {
            caught.Remove(x);
            free.Add(x);
          }
        }
      }
    }
  }

}
