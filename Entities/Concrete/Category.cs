using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        //Çıplak Class Kalmasın eğerki bir class herhangi bir interface implemente almıyorsa giderir.
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
