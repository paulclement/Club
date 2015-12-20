using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PClement.Club.Models
{
    public enum Gender
    {
        Male,
        Female
    }

    public enum DominantSide
    {
        Right,
        Left,
        Ambidextrous
    }

    /// <summary>
    /// see http://www.football-bible.com/soccer-info/soccer-positions-explained.html
    /// </summary>
    public enum PlayerPosition
    {
        /// <summary>
        /// The goalkeeper is simply known as the guy with gloves who keeps the opponents from scoring. He has a special position because only him can play the ball with his hands (provided that he is inside his own penalty area and the ball was not deliberately passed to him by a team mate).
        /// Aside from being the last line of defense, the goalkeeper is the first person in attack. That is why keepers who can make good goal kicks and strategic ball throws to team mates are valuable.
        /// The goalie has four main roles: saving, clearing, directing the defense, and distributing the ball. Saving is the act of preventing the ball from entering the net while clearing means keeping the ball far from the goal area.
        /// The goalkeeper has the role of directing the defense since he is the farthest player at the back and he can see where the defenders should position themselves.
        /// Distributing the ball happens when a goalkeeper decides whether to kick the ball or throw it after making a save. Where the keeper throws or kicks the ball is the first instance of attack.
        /// Some of history’s finest goalkeepers are Lev Yashin, Gordon Banks, Dino Zoff, Peter Schmeichel, and Gianluigi Buffon.
        /// </summary>
        Goalkeeper,
        /// <summary>
        /// A full-back is a defender positioned on the side. They are either classified as left back (LB) or right back (RB). The defenders positioned between them are called centerbacks.
        /// The full-back is tasked to prevent opponents from attacking on the sides. He must be quick and must be able to prevent opponents from making a cross. He is often assigned to mark the opposing winger.
        /// </summary>
        LeftFullBack,
        /// <summary>
        /// A wing-back is a full-back that advances up to the opponent’s goal end. He runs the whole length of the football pitch: he defends the flanks like a dedicated full-back and attacks like a winger.
        /// This is the most physically demanding position on the field. Cafu and Roberto Carlos are two of the best wing-backs ever.
        /// </summary>
        LeftWingBack,
        /// <summary>
        /// In a four-player defense, the center-backs are the two defenders in the middle. They are erroneously called center-halves, because in an obsolete football formation called the 2-3-5, the “3” players are designated with that name. As tactics evolved, the “3” dropped to “center-back” but still retained the name “center-half.”
        /// A center back must be strong, fearless, and good at timing tackles. Being tall is an advantage for a center-back as it allows him to win the ball in the air, an essential skill in corner kick situations. Ronald Koeman, Fabio Cannavaro, and Franco Baresi are some of the greatest center backs of all time.
        /// </summary>
        CenterBack,
        /// <summary>
        /// A full-back is a defender positioned on the side. They are either classified as left back (LB) or right back (RB). The defenders positioned between them are called centerbacks.
        /// The full-back is tasked to prevent opponents from attacking on the sides. He must be quick and must be able to prevent opponents from making a cross. He is often assigned to mark the opposing winger.
        /// </summary>
        RightFullBack,
        /// <summary>
        /// A wing-back is a full-back that advances up to the opponent’s goal end. He runs the whole length of the football pitch: he defends the flanks like a dedicated full-back and attacks like a winger.
        /// This is the most physically demanding position on the field. Cafu and Roberto Carlos are two of the best wing-backs ever.
        /// </summary>
        RightWingBack,
        /// <summary>
        /// A sweeper is located at the back of the defensive line, just in front of the keeper. This position is no longer popularly used in the modern game but was popular in the past especially with the catenaccio system of Italy.
        /// A sweeper’s task is to clear the ball in case it breaks through the defenders. He does not man-mark an opponent so he can collect loose balls or go upfield to bring the ball forward in attack. The German football legend Franz Beckenbauer is the most remarkable of all sweepers.
        /// </summary>
        Sweeper,
        /// <summary>
        /// A defending or holding midfielder is stationed just in front of the defensive line. His responsibility is to prevent the ball from reaching the defensive line. He must be skilled at intercepting passes, tackling the ball, and positioning themselves strategically.
        /// Claude Makelele and Dunga are two of the great holding midfielders.
        /// </summary>
        DefendingMidfielder,
        /// <summary>
        /// A central midfielder is stationed at the center of the field. If he plays both offense and defense, he is called a box-to-box midfielder. The name implies that he runs from his own penalty box to the opponent’s to fulfill different roles.
        /// A box-to-box midfielder does the following: create opportunities for the striker and stop the opponent’s attacks. Stamina, technical ability, and relentless hard-work are the attributes of this type of midfielder. Steven Gerrard is the best box-to-box midfielder of his era.
        /// </summary>
        CentralMidfielder,
        /// <summary>
        /// The attacking midfielder is an advanced midfield player who is primarily inclined to attack. He must have excellent ball control abilities and tactical awareness.
        /// A playmaker occupies the same position as an attacking midfielder but performs a different role. This guy is considered the brain of the team, the most skilled player who orchestrates the attack and distributes the ball. A playmaker must be good in decision-making and as the football saying goes: when you don’t know what to do with the ball, you pass it to him.
        /// The playmaker often wears the number 10 jersey. Some of the most famous playmakers in football are Zico, Zinedine Zidane, and Juan Riquelme.
        /// </summary>
        AttackingMidfielder,
        /// <summary>
        /// The attacking midfielder is an advanced midfield player who is primarily inclined to attack. He must have excellent ball control abilities and tactical awareness.
        /// A playmaker occupies the same position as an attacking midfielder but performs a different role. This guy is considered the brain of the team, the most skilled player who orchestrates the attack and distributes the ball. A playmaker must be good in decision-making and as the football saying goes: when you don’t know what to do with the ball, you pass it to him.
        /// The playmaker often wears the number 10 jersey. Some of the most famous playmakers in football are Zico, Zinedine Zidane, and Juan Riquelme.
        /// </summary>
        PlayMaker,
        /// <summary>
        /// The winger plays the same role as the attacking midfielder but he focuses his attacks from the side. This position is often utilized in “odd” formations like 4-3-3 and 4-5-1.
        /// Since the winger often plays between the midfield and the offensive line, he is sometimes classified as a forward. A player who occupies this position must be fast, have excellent dribbling abilities, and accurate with passes.
        /// A modern winger is typically flexible and can attack from the center, which makes him take over the role of a forward. Ryan Giggs and Garrincha are two excellent examples of wide midfielders.
        /// </summary>
        LeftWinger,
        /// <summary>
        /// The winger plays the same role as the attacking midfielder but he focuses his attacks from the side. This position is often utilized in “odd” formations like 4-3-3 and 4-5-1.
        /// Since the winger often plays between the midfield and the offensive line, he is sometimes classified as a forward. A player who occupies this position must be fast, have excellent dribbling abilities, and accurate with passes.
        /// A modern winger is typically flexible and can attack from the center, which makes him take over the role of a forward. Ryan Giggs and Garrincha are two excellent examples of wide midfielders.
        /// </summary>
        RightWinger,
        /// <summary>
        /// Center-forwards are positioned closest to the opponent’s goal. They have two roles: first, they score goals through passes from teammates; second, they distract the defense to give room for the attacking midfielder, winger, or withdrawn striker to attack.
        /// A striker must be brilliant at receiving and controlling the ball, must be strong, and capable of winning the ball in the air. Skills at playing with the back to the goal is a prerequisite. Some of the greatest strikers of all time are Batistuta, Ruud van Nistelrooy, and Ronaldo.
        /// </summary>
        Striker,
        /// <summary>
        /// The withdrawn striker plays behind the forward. It is typical in attacking football strategies to put him as the main scorer while the person in front of him serves as decoy. The deep-lying forward is often utilized in the 4-4-2 formation.
        /// A deep-lying forward must have excellent passing skills as he is expected to feed the striker and at the same time possess technical abilities with the ball as he often receives back passes from the striker. Pele played as second striker during his illustrious career.
        /// </summary>
        SecondForward
    }

    public enum StaffRole
    {
        President,
        VicePrecident,
        Staff,
        Coach
    }
}
