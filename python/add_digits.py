class Solution:
    def addDigits(self, num: int) -> int:

        digits_sum = 0
        for i in str(num):
            digits_sum += int(i)

        if len(str(digits_sum)) == 1:
            return digits_sum
        return self.addDigits(digits_sum)
