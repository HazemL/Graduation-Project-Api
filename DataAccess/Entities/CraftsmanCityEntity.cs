using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities;

public class CraftsmanCityEntity: BaseModelEntity
{
   

    [ForeignKey("Craftsmens")]
    public int CraftsmanId { get; set; }
    public virtual CraftsmanEntity? Craftsman { get; set; }

    [ForeignKey("Citys")]
    public int CityId { get; set; }
    public virtual CityEntity? City { get; set; }

    public bool IsPrimary { get; set; }
}
