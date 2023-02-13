class Solution:
    def __init__(self):
        self.unique_nums = []

    def isHappy(self, num: int) -> bool:
        square_sum = 0

        for i in str(num):
            square_sum += int(i) ** 2

        if num in self.unique_nums:
            self.unique_nums = []
            return False

        if square_sum == 1:
            self.unique_nums = []
            return True
        else:
            self.unique_nums.append(num)
            return self.isHappy(square_sum)
