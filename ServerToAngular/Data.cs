using ServerToAngular.Models;

namespace ServerToAngular
{
    public class Data
    {
        public static List<Donor> donors = new List<Donor>
        {
            new Donor(1,"aaa","aaaaaaaaaa") ,
            new Donor(2,"bbb","bbbbbbbbbb"),
            new Donor(3,"ccc","cccccccccc")

        };

        public static List<Gift> gifts = new List<Gift>
        {
            new Gift(1,"camera",donors[0],30,"1.png","good camera") ,
            new Gift(2,"car",donors[1],40,"2.png","good car"),
            new Gift(3,"house",donors[2],50,"3.png","good house"),
            new Gift(4,"gift",donors[1],60,"4.png","good gift")
        };
        
        public static List<User> users = new List<User>
        {
            new User(1,"user1","user1","12345678",gifts),
            new User(2,"user2","user2","44444444",gifts),
            new User(3,"user3","user3","87878787",gifts)
        };
    }
}
