using System.Collections.Generic;

namespace HairSalon
{
  public class Stylist
  {
    public void Stylist()
    {
      this.Clients = new HashSet<CollectionExtensions>();
    }
    public int StylistId { get; set; }
    public string StylistName { get; set; }
    public string Specialty { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}