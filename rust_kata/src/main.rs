
fn main(){
    let sheeps = [true,  true,  true,  false,
        true,  true,  true,  true ,
        true,  false, true,  false,
        true,  false, false, true ,
        true,  true,  false,  true ,
        false, false, true,  true];
    let count = count_sheep(&sheeps);
    println!("{count}");

    let sum = summation(2);
    eprintln!("{sum}");

    let returned_string = remove_char("eloquent");
    println!("{returned_string}");
}

pub fn remove_char(s: &str) -> String {

    // Your code here!
    String::from("Code on, rustacean!")
}

fn count_sheep(sheep: &[bool]) -> u8 {
    let mut count = 0;
    for &s in sheep {
        if s == true {
            count += 1;
        }
    }
    return count;
}

fn summation(n: i32) -> i32 {
    // Kata voted best practice was, I think its hard to quickly know what it does
    // (1..=n).sum()
    let mut sum =0;
    let mut count = 1;
    while count <= n {
        sum += count;
        count += 1;
    }
    return sum;
}


