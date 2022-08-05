using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }
    [Display(Name = "Machine Name")]
    public string Name { get; set; }
    [Display(Name = "Last Inspection Date"), DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime LastInspectionDate { get; set; }
    [Display(Name = "Next Inspection Date"), DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime NextInspectionDate { get; set; }

    public virtual ICollection<EngineerMachine> JoinEntities { get;}
  }
}