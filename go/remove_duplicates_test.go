package problems

import (
	"testing"

	"reflect"
)

func TestRemoveDuplicates(t *testing.T) {

	input := [3]int{1, 1, 2}
	expected := 2
	actual := removeDuplicates(input[:])

	if !reflect.DeepEqual(expected, actual) {
		t.Errorf("Expected: %v actual: %v ", expected, actual)
	}
}
