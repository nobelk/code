fn main() {
    println!("Sum of even fibonacci number");

    let mut sum = 2;

    let mut first = 1;
    let mut second = 2;

    loop {

        let current = first + second;
        first = second;
        second = current;

        if current%2 ==0 {
            sum += current;
        }

        if current >= 4000000 {
            break;
        }
    }

    println!("{}", sum);
}