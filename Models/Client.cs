using Systems.Collections.Generic;

namespace HairSalon.Models
{
  public class Clients
  {
    public int ClientId { get; set; }
    public string ClientName { get; set; }
    public string PhoneNumber { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}