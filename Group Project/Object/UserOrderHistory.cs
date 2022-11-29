public class UserOrderHistory{
    private List<Order> orderlist;
    private PickUpTime timebook;
    public UserOrderHistory(PickUpTime timebook){
        this.timebook = timebook;
        this.orderlist = new List<Order>();
    }
    public PickUpTime GetTimebook(){
        return this.timebook;
    }
    public void AddOrdertoHistory(Order order){
        this.orderlist.Add(order);
    }
    public void ShowOldOrder(){
        int n = 1;
        foreach(Order order in this.orderlist){
            Console.WriteLine("-----------------------");
            Console.WriteLine("{0} : {1} X {2} : {3}",n,order.GetMenuName(),order.GetAmount(),order.GetTotalPrice());
            n++;
        }
    }
}