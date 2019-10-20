package main

import "fmt"

func main() {
	fmt.Println("Fibonacci series: ")
	fmt.Println(fibonacci(8))
}

func fibonacci(n int) int {

	if(n==1 || n==2){
		return 1
	}

	return fibonacci(n-1) + fibonacci(n-2)
}