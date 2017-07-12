using System.Collections.Generic;

namespace DungeonsAndDragons.v1.Domain
{
    public class Inventory
    {
        public IEnumerable<InventoryItem> Items { get; set; }
    }
}