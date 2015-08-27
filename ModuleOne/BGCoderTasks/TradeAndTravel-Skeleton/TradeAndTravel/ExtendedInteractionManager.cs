using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public class ExtendedInteractionManager : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default:
                    return base.CreateItem( itemTypeString,  itemNameString, itemLocation, item);
            }
            return item;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "mine":
                    location = new Mine(locationName);
                    break;
                case "forest":
                    location = new Forest(locationName);
                    break;
                default:
                    return base.CreateLocation(locationTypeString, locationName);
            }

            return location;
            
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            { 
                case "gather":
                    this.HandleGatherInteraction(actor, commandWords[2]);
                    break;
                case "craft":
                    this.HandleCraftInteraction(actor, commandWords[2], commandWords[3]);
                    break;
                default:
                    break;
            }
            base.HandlePersonCommand(commandWords, actor);
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            switch (personTypeString)
            { 
                case "merchant":
                    return new Merchant(personNameString, personLocation);
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
        }

        protected void HandleGatherInteraction(Person actor, string newName)
        {
            if (actor.Location is IGatheringLocation)
            { 
                var gatheringLocation = actor.Location as IGatheringLocation;

                if (actor.ListInventory().Any(x => x.ItemType == gatheringLocation.RequiredItem))
                {
                    this.AddToPerson(actor, gatheringLocation.ProduceItem(newName));
                }
            }
        }

        private void HandleCraftInteraction(Person actor, string typeItem, string newItemName)
        {
            switch (typeItem)
            { 
                case "weapon":
                    this.HandleWeaponCrafting(actor, newItemName);
                    break;
                case "armor":
                    this.HandleArmorCrafting(actor, newItemName);
                    break;

            }
        }

        private void HandleArmorCrafting(Person actor, string newItemName)
        {
            var itemRequired = ItemType.Iron;

            if (actor.HasItemInInventory(itemRequired))
            {
                this.AddToPerson(actor, new Armor(newItemName));
            }
        }

        private void HandleWeaponCrafting(Person actor, string newItemName)
        {
            var itemsRequired = new List<ItemType> { ItemType.Iron, ItemType.Wood };

            if (itemsRequired.All(i => actor.HasItemInInventory(i)))
            {
                this.AddToPerson(actor, new Weapon(newItemName));
            }


        }

      
    }
}
