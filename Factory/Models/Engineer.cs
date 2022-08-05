using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    
    public int EngineerId { get; set; }
    public string Name { get; set; }
    private bool _isWorking = false;
    public bool IsWorking
    {
      get
      {
        return _isWorking;
      }
      set
      {
        _isWorking = value;
      }
    }

    public virtual ICollection<EngineerMachine> JoinEntities { get; }
  }
}