public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        IList<IList<int>> result = new List<IList<int>>();
        List<int> currentCombination = new List<int>();
        
        Backtrack(candidates, target, 0, currentCombination, result);
        
        return result;
    }
    
    private void Backtrack(int[] candidates, int remainingTarget, int start, List<int> currentCombination, IList<IList<int>> result) {
        if (remainingTarget < 0) {
            return; // Stop if the remaining target becomes negative
        } else if (remainingTarget == 0) {
            result.Add(new List<int>(currentCombination)); // Add the current combination to the result
            return;
        }
        
        for (int i = start; i < candidates.Length; i++) {
            currentCombination.Add(candidates[i]); // Choose
            Backtrack(candidates, remainingTarget - candidates[i], i, currentCombination, result); // Explore
            currentCombination.RemoveAt(currentCombination.Count - 1); // Unchoose
        }
    }
}
