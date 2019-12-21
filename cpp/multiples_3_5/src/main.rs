fn main() {
    println!("Multiples of 3 and 5 bellow 1000");
    let mut sum =0;

    for i in 0..1000 {

        if i%3 == 0 || i%5 ==0 {
            sum += i;
        }
    }

    println!("{}", sum);
}