#include "ITwoSum.h"
#include <unordered_map>

class TwoSumV2 : public ITwoSum {
public:
    std::vector<int> find(const std::vector<int>& nums, int target) const override {
        int i = 0;
        std::unordered_map<int, int> hashTable;

        while (i < nums.size()) {
            int num = nums[i];
            int complement = target - num;

            if (hashTable.find(complement) != hashTable.end()) {
                return {hashTable[complement], i};
            }

            hashTable[num] = i;
            ++i;
        }

        return std::vector<int>();
    }
};
