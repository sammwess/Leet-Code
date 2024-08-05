#include "ITwoSum.h"
#include <unordered_map>

class TwoSum : public ITwoSum {
public:
    std::vector<int> find(const std::vector<int>& nums, int target) const override {
        int numsSize = nums.size();
        std::unordered_map<int, int> hashTable;

        for (int i = 0; i < numsSize; ++i) {
            int complement = target - nums[i];

            if (hashTable.find(complement) != hashTable.end()) {
                return {hashTable[complement], i};
            }

            hashTable[nums[i]] = i;
        }

        return std::vector<int>();
    }
};
