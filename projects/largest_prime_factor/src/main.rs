fn main() {

    let upper_limit_init: i64 = 600851475143;
    let mut upper_limit: i64 = 600851475143;
    println!("Largest prime factor for {}", upper_limit);

    let mut largest_prime_factor = 2;
    if upper_limit % largest_prime_factor == 0 {
        
        upper_limit = upper_limit/largest_prime_factor;
    }

    let mut current_factor : i64 = largest_prime_factor + 1;
    loop {

        println!("factor: {} upper_limit: {}", current_factor, upper_limit);

        if upper_limit % current_factor == 0 {
            upper_limit = upper_limit/current_factor;
            largest_prime_factor = current_factor;
        }
            
        current_factor += 2;

        if upper_limit == 1 || current_factor * current_factor > upper_limit_init{
            break;
        }
    }

    println!("Largest prime factor of {0} is {1}", upper_limit_init, largest_prime_factor);
}