import { useEffect, useState } from 'react';
import { Bowler } from '../types/Bowler';

function BowlerList() {
  const [Bowl, setBowlData] = useState<Bowler[]>([]);

  useEffect(() => {
    const fetchBowlData = async () => {
      const rsp = await fetch('http://localhost:5224/Bowler'); //go to the link that has the data (local host guy)
      const b = await rsp.json();
      setBowlData(b);
    };
    fetchBowlData();
  }, []);

  return (
    <>
      <div>
        <h4>Bowler List</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {Bowl.map((f) => (
            <tr key={f.bowlerID}>
              <td>{f.bowlerName}</td>
              <td>{f.teamName}</td>
              <td>{f.address}</td>
              <td>{f.city}</td>
              <td>{f.state}</td>
              <td>{f.zip}</td>
              <td>{f.phoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
