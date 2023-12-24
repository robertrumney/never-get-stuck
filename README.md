# never-get-stuck
A Unity script to prevent player characters from getting stuck in the environment. The script checks the player's velocity and input, and moves the player slightly in a random direction if they are deemed to be stuck. This helps to ensure that the player is able to move freely and avoid getting stuck in corners or other tight spaces

## Installation

To use this script in your Unity project, follow these steps:

1. Download the script file (NeverGetStuck.cs) and add it to your Unity project's Assets folder.
2. Attach the script to your player character's GameObject.
3. Make sure that the player's GameObject has a Rigidbody component.

## Customizing the input axis

By default, the script uses the "Horizontal" and "Vertical" input axis to determine the player's movement input. However, you can customize the script to use different input axis if needed.

You'll also need to make sure that you have configured your custom input axis in the Unity Input Manager. To do this, go to the "Edit > Project Settings > Input" menu in the Unity editor and add your custom input axis to the list. You can then specify the positive and negative keys or buttons that correspond to each axis.

## Usage

To use the script, simply attach it to your player character's GameObject and make sure that the player has a Rigidbody component. The script will automatically check if the player is stuck and move them slightly in a random direction if necessary.

You can adjust the threshold for what is considered "stuck" by modifying the `velocityThreshold` variable in the `CheckIfStuck` method. A smaller threshold will cause the player to be considered stuck more easily, while a larger threshold will require a greater degree of immobility before the player is considered stuck.

## Troubleshooting

If the script is not functioning as expected, here are some potential issues to check:

- Make sure that the script is attached to the player's GameObject and that the player has a Rigidbody component.
- Make sure that the input axis specified in the script match the input axis that are configured in the Unity Input Manager.
- Try adjusting the `velocityThreshold` variable to see if that resolves the issue.

## License

This script is released under the public domain license. You are free to use it as you wish.
