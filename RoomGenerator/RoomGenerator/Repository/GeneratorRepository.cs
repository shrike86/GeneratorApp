using RoomGenerator.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoomGenerator.Repository
{
    public class GeneratorRepository : IGeneratorRepository
    {
        public List<string> Places_1 = new List<string>()
        {
            "Burning", "Hallowed", "Mossy", "Synthetic", "Crystalline", "Sterile", "Claggy", "Ethereal", "Encrusted", "Infested", "Labyrinthine", "Industrial", "Smoky", "Bloodsoaked", "Cursed", "Acidic", "Milky", "Flooded",
            "Molten", "Frozen", "Verdant", "Dripping", "Steaming", "Shadowy", "Shadowy", "Mouldering", "Turbulent", "Sinking", "Floating", "Titanic", "Insectile", "Dusty", "Desecrated", "Abandoned", "Abandoned", "Shimmering"
        };

        public List<string> Places_2 = new List<string>()
        {
            "Cage", "Vine", "Bone", "Boulder", "Shrine", "Mushroom", "Brick", "Pit", "Pool", "Machine", "Sewer", "Ore", "Monument", "Sand", "Cave", "Glass", "Eye", "Obsidian",
            "Marble", "Gem", "Refuse", "Fog", "Rain", "Cliff", "Garden", "Vat", "Graveyard", "Canal", "Slime", "Shell", "Blade", "Needle", "Nest", "Ring", "Dome", "Vapor"
        };

        public List<string> Places_3 = new List<string>()
        {
            "Island.", "Hill.", "Beach.", "Desert.", "Lake.", "Village.", "Temple.", "Cavern.", "Ruin.", "Crater.", "Mountain.", "Bridge.", "Tower.", "Manse.", "Laboratory.", "Plain.", "Jungle.", "Forest.",
            "Factory.", "Prison.", "Library.", "Menagerie.", "Fortress.", "River.", "Town.", "Sea.", "Crypt.", "Hive.", "Swamp.", "Palace.", "Dock.", "Reef.", "Volcano.", "Valley.", "Road.", "Market."
        };

        public List<string> RoomStocking = new List<string>() 
        {
            "Empty, place of rest.", "Empty, place of recreation.", "Empty, place of physical work.", "Empty, place of physical storage.", "Empty, place of sleep.", "Empty, place of ornamentation.", 
            "Empty, place of ritual and worship.", "Empty, place of waste disposal", "Empty, place of eating.", "Empty, place of lavatory.", "Empty, place of mental work and research.", "Empty, place of mental storage", "Empty, place of bathing.", 
            "Empty, place of mechanics and machinery.", "Empty, place of growing.", "Empty, place of secrets.", "Inhabitant, sleeping or resting.", "Inhabitant, conducting relaxation or recreation.", "Inhabitant, physically toiling.", 
            "Inhabitant, hidden and watching.", "Inhabitant, eating or drinking.", "Inhabitant, indisposed through sickness or misadventure.", "Inhabitant, conducting ritual or worship.", "Inhabitant, mentally toiling.", "Inhabitant, ignoring treasure.", 
            "Inhabitant, indulging in treasure.", "Inhabitant, transporting or protecting treasure. ", "Inhabitant, searching for known of treasure.", "Treasure, subsumed in location.", "Treasure, out of place and unusual.", "Treasure, focus of work or worship.", 
            "Treasure, hidden.", "Trap, natural hazard inherent in environment.", "Trap, set by nearby foes, evidence of their work. ", "Trap, obvious and menacing.", "Trap, hidden and deadly.", "Inhabitant, trapped in natural hazard of environment",
            "Inhabitant, using traps to their advantage against interlopers.", "Inhabitant, vaguely aware of trap, but not knowledgeable of specifics.", "Inhabitant, unaware of trap they may be about to trigger.", "Device specific and inherent to environment, expected but intriguing. ", 
            "Device external and unusual to environment, out of place sourced from elsewhere. ", "Device used in regular work of environment, mundane but effective.", "Device with obscure, secret use that belies a shadow use of environment.", 
            "Inhabitant, using device to conduct relatively mundane activity.", "Inhabitant, puzzling over the way in which a device is used.", "Inhabitant, using device effectively to halt interlopers.", "Inhabitant, using device for a dark, devious and deviant purpose." 
        };

        public List<string> RoomAtmosphere= new List<string>()
        {
           "Mutatative Overgrowth and frenzied, manic healing ","Holy, religious and sacred.","Welcoming, calming and accommodating. ","Secure, locked and quarantined. ","Outer space, interstellar planets and stars. ","Wax, flame and candles. ","Wisdom, knowledge and greybeards. ",
            "Flowing, blowing and leaking voluminous gas. ","Cracked and unworking reality, a fundamental malfunction. ","Transcendental meditation, utter calm and dangerously soothing.","Frozen, preserved, pickled, documented and caught. ","Wings - leathered and feathered. ",
            "Air apparati, tube and tanks. ","Ethereal and vaporous - twisting, flowing and floating. ","Crystalline coating - mould like pestilence. ","Billowing spirits, ghostlike fabrics and hauntings. ","Schemes, hidden costs and charges, tolls and payments. ",
            "Overfluid movement, frenzied speed and savage quickness. ","A myriad of amulets, charms, fetishes and trinkets.","Beast of burdenesque, four legs, load bearing and carrying. ","Shrunken, small and shriveled - rotted and wrecked. ",
            "Clambering hordes of vermin and insects, controlled and wild. ","Bare, barren, stripped of splendour and excess. ","Ooze ridden and globular, slime covered and excreting. ","Hidden power, force and horror, barely trapped away. ",
            "Fake, disguised and misleading, nothing is as it appears. ","All is eyes and sentinels, never ending watching. ","Regrown and rebuilt - clearly signs of limbs and quarters once missing. ","Gourmet, gourmand and gassy - flabbular feasting. ",
            "Clear, translucent, delicate and dazzling. ","Obesily opulent, gilded and bejewelled ","Hordes, crowds and hives. ","Brains, books, minds and libraries. ","Encroachment of the psychic realms and dreamlands. ","Mindless, drooling, thoughtless and lobotomized. ",
            "Internal organs on display, fleshy, bloody and sanguine. ","Self consumptive and destructive. ","Reflection, mirrored image and repetition. ","Entombment, gilded prisons and grand cages. ","Metal and minerals. ","The sun and or the moon.",
            "Aquatic creatures, scales, fins and gills. ","Oppressive heat, dryness and flame. ","Frozen, cold, frigid and icy. ","Spring new life, or autumn decay. ","Liquid waste, sewage and stinking effluent. ","Sizzling acid or burning magma. ",
            "Measurement, judgement, jealousy and control. ","Thick plating and armour, layers of protective outer coating. ","Bars,locks, spikes, poles and pikes.","Shamanic effigies, virule animism and encroachment from the spirit world. ",
            "Vegetative construction, swirling vines, leaves and flowers. ","Overgrown, gigantic and cyclopic. ","Meat, butchers, carcesses, bones, carrion beasts and birds. ","Toothy, hairy and boney feral. ","Many limbed, headed, eyed and tentacled. ",
            "Visions of unreality, psychedelia and the not quite real. ","Scents, over alluring or oppressive. ","Petals, pollens, bursting ripe fruit. ","Chance, luck, unbelievable odds balancing delicately on the precipice","Fire, flames and burning. ",
            "Lanterns, bonfires, fireplaces and braziers. ","Destruction, ruin, rubble, rocks and wreck. ","Mountainous rubbish, rolling refuse and towering waste. ","Wheels, cogs, gears and ever turning mechanisms. ","Sailing and ships, maps and exploration. ",
            "Automatons, robots, man replicas, simulacrum and sentient copies. ","Alien, beyond exotic and otherworldly. ","Mechanical, gears, chains and motors. ","Molluscs, cephalopods and gastropods. ","Beastial visage - theeth, claws, fur, scales, tails, hooves and the like. ",
            "Oversized, enormous, overgrown - repulsive in mass. ","Masks and mockery, fakery and disguises. ","Fins, scales, tentacles and jellyfish. ","Monstrous and horrible, misshapen and obscene. ","Silk, robes, flowing cloth, luxurious, soft and enveloping. ",
            "Pillars, stilts, stalks and ladders. ","Wood - worked, raw, polished, painted and bare. ","Chains and binding, ropes, knots and bondage. ","Inebriation, sensualness, orgies and panic. ","Tunnels, holes and craters. ","Bugs, beetles, carapacea and compound eyes. ",
            "Encasement in crystal and mineral calcification. ","Dirt, mud, soil, humus, sand. ","Ornate and polished stone, smooth, shiny marble. ","Interdimensional rifts, gates and portals - things creeping though. ","Time slow and fast. ","Dust, crumbling, ash and ruin. ",
            "Samples, fetishes, preserved parts of dead wholes."," Beneath, upside down, covered and hidden. ","Contorted - twisting forms of tortured pain. ","Things in places they should not be - the world topsy turvy. ","Relics, gravestones, holy skeletons and bodies. ",
            "Mazes, labyrinths and puzzles. ","Shadows, darkness, malformity. ","Rotted, liquefying and putrid to the point of slop. ","Sickness, disease and plague. ","Deformed, demented and wrong. ","Bones, tusks and skulls. ","Veins and vines. "
        };

        public List<string> Ornamentations_1 = new List<string>()
        {
            "Vases","Stone hands","Stone hoops","Gloves","Bracelets","Ornate lanterns","Candles in jars","Necklaces","Fabric bunting","Masks",
            "Decorative stones","Bundles of feathers","Scarfs","Decorative skulls","Cloaks","Trained beasts","Decorative barrels","Chunks of crystal",
            "Rings","Helmets","Headdresses","Amulets","Tall mirrors","Decorative mushrooms","Noble costumes","Decorative weapons","Tiny ",
            "Capes","Eye patches","Collars","Candles","Plants","Brooches","Belts","Diadems","Crowns","Pendants","Signet rings","Statuettes",
            "Tiny boxes","Chests","Hand mirrors","Glass bottles","Fake limbs","Cages","Flasks","Wood carvings","Preserved tiny beasts",
            "Large insects","Shrines","Hats","Eye glasses","Glass boxes","Bowls","Pipes","Small contraptions","Decorative scrolls","Decorative maps",
            "Candelabras","Tables","Chairs","Ornate doors","Pots","Tiny trees","Banners","Glowing canisters of liquid","Glowing canisters of gas",
            "Large hooks","Stained glass windows","Decorative bones","Jugs","Thrones","Shoes","Boots","Hoods","Arches","Columns","Paintings",
            "Earrings ","Precious stones "
        };

        public List<string> Ornamentations_2 = new List<string>()
        {
            "Amazingly attractive","Sharply symmetrical","Sturdily strong","Impressively capable","Bright glowing","Flecked with radiance",
            "Swirling with plasma","Blinding to look at","Floating","Leaking gas","Overly bulbous","Far too Flat","Easy to hide","Strangely ghostly",
            "Vaguely incorporeal","Coated in mist","Shimmering brightly","Decorated with spikes","Dangerously sharp","Incomplete","Confusing to look at",
            "A jumble of parts and pieces","Skeletal","Filled with holes","Dripping with liquid","Translucent","Flickering in and out of ",
            "Semi intangible","Diffused over a larger area than is normal","In pairings of twins","Decorated with limbs","Decorated with heads",
            "Shaped like hands","Gilded with gems","Plated in shining metal","Shimmering with lustour","Plainly bare","Made of skin or flesh",
            "Made of preserved organs","Ever warping in appearance","Always camouflaged","Oozing slime","Scaley","Caustic to the touch",
            "Covered in thorns","Metal plated","Sizzling with acid","Made of beetle husks","Oversized","Made of plant matter","Covered in flowers",
            "Warped","Very poorly constructed","Smoking","Flaming","Burnt","Rotting","Crumbling","Foul","Tattered","Covered in geometric symbols",
            "Blood soaked","Covered in bugs","Squirming with worms","Infused with minerals","Rock hard","Infused with eyes","Falling apart with age",
            "Incredibly old","Bladed","Covered in needles","Decorated with leering faces","Very soft and padded","Crackling with fey energy",
            "Seeping shadows","Inherently vile","Bubbling with rot","Covered in pustules","Made of scavenged material","Leaking a foul gas"
        };

        public string GetRoomStocking()
        {
            var index = new Random().Next(0, RoomStocking.Count - 1);
            return RoomStocking[index];
        }

        public string GetRoomAtmosphere()
        {
            var index = new Random().Next(0, RoomAtmosphere.Count - 1);
            return RoomAtmosphere[index];
        }

        public string GetPlaces1()
        {
            var index = new Random().Next(0, Places_1.Count - 1);
            return Places_1[index];
        }

        public string GetPlaces2()
        {
            var index = new Random().Next(0, Places_2.Count - 1);
            return Places_2[index];
        }

        public string GetPlaces3()
        {
            var index = new Random().Next(0, Places_3.Count - 1);
            return Places_3[index];
        }

        public string GetOrnamentations1()
        {
            var index = new Random().Next(0, Ornamentations_1.Count - 1);
            return Ornamentations_1[index];
        }

        public string GetOrnamentations2()
        {
            var index = new Random().Next(0, Ornamentations_2.Count - 1);
            return Ornamentations_2[index];
        }
    }
}
