#include <iostream>
#include <vector>
#include <unordered_map>


using namespace std;

std::vector<int> twoSum(std::vector<int>& nums, int target);
std::vector<int> twoSumV2(std::vector<int>& nums, int target);

int main() {
    std::vector<int> nums = {3, 2, 4};
    int target = 6;

    auto start = std::chrono::high_resolution_clock::now();

    std::vector<int> result = twoSumV2(nums, target);

    auto end = std::chrono::high_resolution_clock::now();
    std::chrono::duration<double, std::milli> duration = end - start;

    if (!result.empty()) {
        std::cout << "Indices found: " << result[0] << " and " << result[1] << std::endl;
    } else {
        std::cout << "No pair found that sums to the target." << std::endl;
    }

    std::cout << "Time taken: " << duration.count() << " ms" << std::endl;

    return 0;
}

vector<int> twoSum(vector<int>& nums, int target) {

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

vector<int> twoSumV2(vector<int>& nums, int target) {

        int i = 0;
        std::unordered_map<int, int> hashTable;

        loop_start:

        int num = nums[i];
        int complement = target - num;
    
        if (hashTable.find(complement) != hashTable.end()) {
            return {hashTable[complement], i};
        }

        hashTable[num] = i;
        ++i;

        goto loop_start;
}
