package it.bebox.kata;

import org.apache.commons.lang3.StringUtils;

import java.util.*;

public class FizzBuzz {

    private final LinkedHashMap<Integer, String> rules;

    public FizzBuzz() {
        rules = new LinkedHashMap<Integer, String>() {{
            put(15, "FizzBuzz");
            put(3, "Fizz");
            put(5, "Buzz");
        }};
    }

    public String play() {
        List<String> results = new ArrayList<String>();

        for (int i = 1; i <= 100; i++) {

            int j = i;
            Optional<Map.Entry<Integer, String>> first = rules.entrySet().stream().filter(item -> canBeDividedBy(j, item.getKey())).findFirst();
            if (first.isPresent())
                results.add(first.get().getValue());
            else results.add(Integer.toString(i));
        }

        return StringUtils.join(results.iterator(), "\n");
    }

    private boolean canBeDividedBy(Integer i, Integer divisor) {
        return restOfDivision(i, divisor) == 0;
    }

    private int restOfDivision(Integer i, Integer divisor) {
        return i % divisor;
    }
}
