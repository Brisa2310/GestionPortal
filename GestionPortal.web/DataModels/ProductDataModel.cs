using System.ComponentModel.DataAnnotations;

namespace GestionPortal.web.DataModels
{
    public class ProductDataModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Category { get; set; }
    }
}
