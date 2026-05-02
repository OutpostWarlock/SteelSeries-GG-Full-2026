package main
import "fmt"
func fibonacci(n int) []int{
result := make([]int, n)
if n > 0 {
result[0] = 0
}
if n > 1 {
result[1] = 1
}
for i := 2; i < n; i++ {
result[i] = result[i-1] + result[i-2]
}
return result
}
func main() {
n := 10
fibSeq := fibonacci(n)
for i, v := range fibSeq {
fmt.Printf("Fibonacci[%d] = %d\n", i, v)
}
}
