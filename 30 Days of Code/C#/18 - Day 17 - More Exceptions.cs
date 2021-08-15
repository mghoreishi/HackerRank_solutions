class Calculator {
	public int power(int n, int p) {
		if (n < 0 || p < 0) {
			throw new Exception("n and p should be non-negative");
		}
		else {
			return Convert.ToInt32(Math.Pow(n, p));
		}
	}
}
