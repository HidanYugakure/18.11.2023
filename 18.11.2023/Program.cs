

using _18._11._2023.Models;
using System.Text;

Console.OutputEncoding=Encoding.UTF8; //Menim aglima geldi sual arasdirib tapdiq bu usul AZ herflerinden istifade etmek ucundu 
GunGameMeny gunGameMeny=new GunGameMeny();
gunGameMeny.GameMeny();
GunTypes gunTypes = new GunTypes();
gunTypes.GunMethodTypes();
TemsSelect TemsSelect = new TemsSelect();
TemsSelect.SelectYourGunsTems();
TheStartGame startThe = new();
startThe.CagirmaqStartTheGame();



