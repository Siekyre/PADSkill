using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using HtmlAgilityPack;
using System.Windows;

namespace PadSkill
{
    class Program
    {
        static void Main(string[] args)
        {
            //for now, just use the files; leave padherder.com alone
            string monsterDataFile = @"C:\Users\Keith\source\repos\PadSkill\monsterData.json";
            string monsterData = new StreamReader(monsterDataFile).ReadLine();
            List<Monster> monsters = JsonConvert.DeserializeObject<List<Monster>>(monsterData);

            string monsterActiveSkillsFile = @"C:\Users\Keith\source\repos\PadSkill\monsterActiveSkills.json";
            string monsterActiveSkill = new StreamReader(monsterActiveSkillsFile).ReadLine();
            List<ActiveSkill> activeSkill = JsonConvert.DeserializeObject<List<ActiveSkill>>(monsterActiveSkill);


            // FIRST:  load main page
            //string padx_url = @"http://puzzledragonx.com/?dir=1"; //padx dungeon schedule (main)
            string padx_url = @"C:\Users\Keith\OneDrive\Documents\PADX\PADX_MainPage_09_27_2017.html";

            HtmlWeb padxSite = new HtmlWeb();
            HtmlDocument padxMainPage = padxSite.Load(padx_url);

            HtmlNodeCollection mainnodes = padxMainPage.DocumentNode.SelectNodes("dungeon");
/*FIRST:  extract Puzzles and Dragons Dungeon Schedule
FIRST:  create list of dungeons to open
FIRST:  load first dungeon in list
                                OPTIMIZE:  check datetime; check cache for date range active, don't scrape if within date range still; I will have *usually* gathered the data the first time it appears
                                LATER:  look for qualifiers in same row (changes drop rate)
                                OPTIMIZE:  usually this is limited to 24 hour periods; sometimes not; detect those and surface them
                store dt, title, save link to dungeon information page
                open link
                
                extract sub dungeon section
                                save title, stamina
                extract Major Encounters section
                                extract each row
                                                extract loot (there can more than one (like in collab monster OR weapon drops))
                                                extract loot ID
                                                extract loot skill name
                                                save
                                
                                
                
                extract Dungeon section
                extract list of dungeons (hardest dungeon is at the top)
                                OPTIMIZE:  surface skill levels for skill up food separately.
                                extract aref list (shouldn't progress past the extracted section; current dungeon is 
                                                store name for each other dungeon)

    */

        }
    }
}
