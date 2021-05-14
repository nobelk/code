package hello

import "testing"

func TestHello(t *testing.T) {
	expected := "Bismillah."
	if actual := Hello(); actual != expected {
		t.Errorf("actual = %q, expected %q", actual, expected)
	}
}

func TestHello1(t *testing.T) {
	expected := "Hello, world."
	if actual := Hello1(); actual != expected {
		t.Errorf("actual = %q, expected %q", actual, expected)
	}
}
