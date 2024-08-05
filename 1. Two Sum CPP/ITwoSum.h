#ifndef ITWOSUM_H
#define ITWOSUM_H

#include <vector>

class ITwoSum {
public:
    virtual ~ITwoSum() = default;
    virtual std::vector<int> find(const std::vector<int>& nums, int target) const = 0;
};

#endif // ITWOSUM_H
