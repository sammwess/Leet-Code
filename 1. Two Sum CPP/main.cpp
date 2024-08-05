#include <iostream>
#include <vector>
#include <memory>
#include <chrono>
#include "ITwoSum.h"
#include "TwoSum.cpp"
#include "TwoSumV2.cpp"

int main() {
    std::vector<int> nums = {3, 2, 4};
    int target = 6;

    // Choose implementation to test
    std::unique_ptr<ITwoSum> twoSumImpl = std::make_unique<TwoSum>();

    auto start = std::chrono::high_resolution_clock::now();

    std::vector<int> result = twoSumImpl->find(nums, target);

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
