using CastAutomation.MODEL.ORM.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastAutomation.MODEL.ORM.InterFace
{
    public interface IBaseEntity
    {
         int ID { get; set; }
        DateTime AddDated { get; set; }
        DateTime UpdatedDate { get; set; }
        DateTime DeletedDate { get; set; }
        //Status status { get; set; }

    }
}
