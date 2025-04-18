public class Solution {
public int[] TwoSum(int[] nums, int target) {
for (int i = 0; i < nums.Length; i++) { //pętla przechodzi przez każdy element tablicy nums
    for (int j = i + 1; j < nums.Length; j++) { //pętla sprawdza wszystkie kolejne liczby po i | (i + 1)
        if (nums[i] + nums[j] == target) { return new int[] { i, j }; } //zwrot tablicy zawierająca indeksy tych dwóch liczb
    } 
}
return new int[0]; } //zwrócenie pustej tablicy, gdy żadna para nie pasuje 
}