

namespace Shopp.Web.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IEntity
    {//con la clase IEntity obligamos que todas las clases que la heredan tengan el atributo Id

     int Id { get; set; }

    }
}
