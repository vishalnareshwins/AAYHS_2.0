import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatSnackbarComponent } from 'src/app/shared/ui/mat-snackbar/mat-snackbar.component';

@Component({
  selector: 'app-distribution-sponsor-modal',
  templateUrl: './distribution-sponsor-modal.component.html',
  styleUrls: ['./distribution-sponsor-modal.component.scss']
})
export class DistributionSponsorModalComponent implements OnInit {

  constructor(public dialogRef: MatDialogRef<DistributionSponsorModalComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private snackBar: MatSnackbarComponent,
    public dialog: MatDialog) { }

    totalSponsorAmount: number = null;
    exhibitorPaid: number = null;
    remainedSponsorAmount: number = null;
    sponsorname:string=null;
  ngOnInit(): void {
    this.totalSponsorAmount=this.data.sponsorTotal,
    this.exhibitorPaid=this.data.amountGiving,
    this.remainedSponsorAmount=this.data.remaining,
    this.sponsorname=this.data.sponsorName

  }

  onDismiss(): void {
    // Close the dialog, return false
    this.dialogRef.close(false);
  }
}
