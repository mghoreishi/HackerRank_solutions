//Day 13: Abstract Classes

class MyBook : Book{
    private int price = 0;
    public MyBook(String title, String author, int price) : base(title, author){
        this.price = price;
    }

    public override void display(){
        Console.Write("Title: {0} \nAuthor: {1} \nPrice: {2}", title, author, price);
    }
}
