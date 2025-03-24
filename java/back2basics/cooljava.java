import java.util.Scanner; // Input

public class cooljava{
    public static void novice(int n, String phr){
        if(n > 10){
            System.out.println("Wait up, I only count until 10.");
            return;
        }

        for(int i = 0; i < n; i++){
            System.out.printf("Counting now: %d\n", i);
        }

        System.out.println(phr);

        // Input
        Scanner in = new Scanner(System.in);
        System.out.println("Type something.");
        String name = in.nextLine();
        System.out.println(name);
        in.close();

    }
    public static void main(String[] args){
        System.out.println("Now this is Java!");
        novice(3, "Dummy phrase");
    }
}