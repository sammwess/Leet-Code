#include <gtest/gtest.h>
#include "ITwoSum.h"
#include "TwoSum.cpp"


// TwoSum, input: nums [2,7,11,15], target 9, expects [0,1]
TEST(TwoSum, Nums271115Target9Expects01) {

    std::vector<int> nums = {2, 7, 11, 15};
    int target = 9;

    // Choose implementation to test
    std::unique_ptr<ITwoSum> twoSumImpl = std::make_unique<TwoSum>();
    std::vector<int> result = twoSumImpl->find(nums, target);

    EXPECT_EQ(result[0], 0);
    EXPECT_EQ(result[1], 1);
}

// TwoSum, Testing input: nums [3,2,4], target 6, expects [1,2]
TEST(TwoSum, Nums324Target6Expects12) {

    std::vector<int> nums = {3, 2, 4};
    int target = 6;

    // Choose implementation to test
    std::unique_ptr<ITwoSum> twoSumImpl = std::make_unique<TwoSum>();
    std::vector<int> result = twoSumImpl->find(nums, target);

    EXPECT_EQ(result[0], 1);
    EXPECT_EQ(result[1], 2);
}

// TwoSum, Testing input: nums [3,3], target 6, expects [0,1]
TEST(TwoSum, Nums33Target6Expects01) {

    std::vector<int> nums = {3, 3};
    int target = 6;

    // Choose implementation to test
    std::unique_ptr<ITwoSum> twoSumImpl = std::make_unique<TwoSum>();
    std::vector<int> result = twoSumImpl->find(nums, target);

    EXPECT_EQ(result[0], 0);
    EXPECT_EQ(result[1], 1);
}