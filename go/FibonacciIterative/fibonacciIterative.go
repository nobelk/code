package main

import "fmt"

func main() {
	fmt.Println("Fibonacci series: ")
	fmt.Println(fibonacci(100))
}

func fibonacci(n int) int {

	if(n==1 || n==2){
		return 1
	}

	fibNumber := 0
	firstNumber := 1
	secondNumber := 1
	for counter :=3; counter <=n; counter++ {
		fibNumber = firstNumber + secondNumber
		firstNumber = secondNumber
		secondNumber = fibNumber
	}

	return fibNumber
}